# Sitecore Data Exchange Gutters
One interesting and cool feature of Sitecore is the ability to use gutters. What more interesting is creating custom gutters. Sitecore gutters can be a very useful way of providing a quick solution for context item of an item within the tree.

The current solutions were designed mainly for [Sitecore Data Exchange Framework](https://dev.sitecore.net/Downloads/Data_Exchange_Framework.aspx) (DEF) and its providers. If you are not familiar with DEF, please follow the available [documentation link](http://integrationsdn.sitecore.net/DataExchangeFramework/v1.2/).

There are three available gutters for DEF.
* [DataExchange - Item Disabled](#dataexchange---item-disabled)
* [DataExchange - Pipeline Batch](#dataexchange---pipeline-batch)
* [DataExchange - Pipeline Step](#dataexchange---pipeline-step)

### DataExchange - Item Disabled
By default when you configure a new tenant with its batches and pipeline steps they are disables. This gutter allows not only see it, also, it allows you to set enable.

![Gutter Item Disabled](/source/images/gutter-enable.jpg)

### DataExchange - Pipeline Batch
When you select pipeline batch you have several options:
* **Run It** - allows you to run selected pipeline batch.
* **Clean Summary** - allows you to clean up data under summary section.
* **Display Pipeline Steps** - allows to display chaine of pipeline steps for current batch.

![Gutter Pipeline Batch](/source/images/gutter-pipeline-batch.jpg)

![Command Pipeline Batch](/source/images/command-show-pipeline-steps.jpg)

### DataExchange - Pipeline Step
There is a single option for selected pipeline step is to **display required plugins**.

![Gutter Pipeline Step](/source/images/gutter-pipeline-step.jpg)

![Command Required Plugins](/source/images/command-required.jpg)



