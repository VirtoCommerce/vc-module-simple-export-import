# Virto Commerce Price Export & Import Module

[![CI status](https://github.com/VirtoCommerce/vc-module-price-export-import/workflows/Module%20CI/badge.svg?branch=dev)](https://github.com/VirtoCommerce/vc-module-price-export-import/actions?query=workflow%3A"Module+CI") [![Quality gate](https://sonarcloud.io/api/project_badges/measure?project=VirtoCommerce_vc-module-price-export-import&metric=alert_status&branch=dev)](https://sonarcloud.io/dashboard?id=VirtoCommerce_vc-module-price-export-import) [![Reliability rating](https://sonarcloud.io/api/project_badges/measure?project=VirtoCommerce_vc-module-price-export-import&metric=reliability_rating&branch=dev)](https://sonarcloud.io/dashboard?id=VirtoCommerce_vc-module-price-export-import) [![Security rating](https://sonarcloud.io/api/project_badges/measure?project=VirtoCommerce_vc-module-price-export-import&metric=security_rating&branch=dev)](https://sonarcloud.io/dashboard?id=VirtoCommerce_vc-module-price-export-import) [![Sqale rating](https://sonarcloud.io/api/project_badges/measure?project=VirtoCommerce_vc-module-price-export-import&metric=sqale_rating&branch=dev)](https://sonarcloud.io/dashboard?id=VirtoCommerce_vc-module-price-export-import)


If you want to transfer a large amount of price information between Virto Commerce and another system, you can use a specially-formatted spreadsheet to import or export that data. Virto Commerce uses CSV (semicolon-separated value) files to perform this kind of bulk task.

The business goal for the module is to provide to non-technical not high skilled business users (like "category manager") who works with prices on a daily basis and don't understand the database structure to work comfortably with prices export and import functionality using it for price management.

![Main-Screen](docs/media/main-screen.png)

> **Note:**  
> To automate the transfer of information from third-party systems like ERP, refer to the API, Integration Middleware approach, and Azure Logic Apps connectors.


## Business scenarios
* Export two price lists to make comparing.
* Change multiple prices in the price list of few hundreds of records in the price list.
* Make a bulk price update (+5% for everything) for a price list.
* Add prices for a batch of new products added to the catalog.


## Documentation
* [Price Export and Import module user documentation](https://docs.virtocommerce.org/platform/user-guide/price-export-import/overview/)
* [REST API](https://virtostart-demo-admin.govirto.com/docs/index.html?urls.primaryName=VirtoCommerce.PriceExportImport)
* [View on GitHub](https://github.com/VirtoCommerce/vc-module-price-export-import/)

## Development
Abstractions and implementation including public API can be changed in next releases (breaking changes may be introduced).

## References

* [Deployment](https://docs.virtocommerce.org/platform/developer-guide/Tutorials-and-How-tos/Tutorials/deploy-module-from-source-code/)
* [Installation](https://docs.virtocommerce.org/platform/user-guide/modules-installation/)
* [Home](https://virtocommerce.com)
* [Community](https://www.virtocommerce.org)
* [Download latest release](https://github.com/VirtoCommerce/vc-module-price-export-import/releases/latest)

## License

Copyright (c) Virto Solutions LTD.  All rights reserved.

Licensed under the Virto Commerce Open Software License (the "License"); you
may not use this file except in compliance with the License. You may
obtain a copy of the License at

http://virtocommerce.com/opensourcelicense

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
implied.
