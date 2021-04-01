using System;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.Server;
using VirtoCommerce.Platform.Core.Exceptions;
using VirtoCommerce.Platform.Core.PushNotifications;
using VirtoCommerce.Platform.Hangfire;
using VirtoCommerce.SimpleExportImportModule.Core.Models;
using VirtoCommerce.SimpleExportImportModule.Core.Services;
using VirtoCommerce.SimpleExportImportModule.Web.Helpers;

namespace VirtoCommerce.SimpleExportImportModule.Web.BackgroundJobs
{
    public sealed class ImportJob
    {
        private readonly ICsvPagedPriceDataImporter _dataImporter;
        private readonly IPushNotificationManager _pushNotificationManager;

        public ImportJob(ICsvPagedPriceDataImporter dataImporter,
            IPushNotificationManager pushNotificationManager)
        {
            _dataImporter = dataImporter;
            _pushNotificationManager = pushNotificationManager;

        }

        public async Task ImportBackgroundAsync(ImportDataRequest request, ImportPushNotification pushNotification, IJobCancellationToken jobCancellationToken, PerformContext context)
        {
            ValidateParameters(pushNotification);

            try
            {
                await _dataImporter.ImportAsync(request,
                    progressInfo => ProgressCallback(progressInfo, pushNotification, context),
                    new JobCancellationTokenWrapper(jobCancellationToken));
            }
            catch (JobAbortedException)
            {
                // job is aborted, do nothing
            }

            catch (Exception ex)
            {
                pushNotification.Errors.Add(ex.ExpandExceptionMessage());
                pushNotification.ErrorCount++;
            }

            finally
            {
                pushNotification.Description = "Import finished";
                pushNotification.Finished = DateTime.UtcNow;
                await _pushNotificationManager.SendAsync(pushNotification);
            }
        }

        private void ProgressCallback(ImportProgressInfo x, ImportPushNotification pushNotification, PerformContext context)
        {
            pushNotification.Patch(x);
            pushNotification.JobId = context.BackgroundJob.Id;
            _pushNotificationManager.Send(pushNotification);
        }

        private static void ValidateParameters(ImportPushNotification pushNotification)
        {
            if (pushNotification == null)
            {
                throw new ArgumentNullException(nameof(pushNotification));
            }
        }
    }
}
