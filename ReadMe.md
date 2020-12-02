# GHSDatabase

[![Build Status](https://dev.azure.com/techtoniq/GHS%20Database/_apis/build/status/techtoniq.tq-ghsdatabase?branchName=master)](https://dev.azure.com/techtoniq/GHS%20Database/_build/latest?definitionId=36&branchName=master)  [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=GHS&metric=alert_status)](https://sonarcloud.io/dashboard?id=GHS) [![Techtoniq.GHSDatabase package in TQOpenSource feed in Azure Artifacts](https://feeds.dev.azure.com/techtoniq/_apis/public/Packaging/Feeds/28bc8d4d-7b39-4f58-afa4-38c3b985a4a8/Packages/5300b000-23d5-410f-aef5-5af372994475/Badge)](https://dev.azure.com/techtoniq/GHS%20Database/_packaging?_a=package&feed=28bc8d4d-7b39-4f58-afa4-38c3b985a4a8&package=5300b000-23d5-410f-aef5-5af372994475&preferRelease=true)

GHS is the [Globally Harmonised System (GHS)](https://www.hse.gov.uk/chemical-classification/legal/background-directives-ghs.htm) for chemical hazard classification. 

This Nuget package provides an in-memory database of hazard codes, phrases, pictograms, labels and other data from GHS.


## Example Usage

```c#
    IGhsDatabase ghsdb = new GhsDatabase();
    IHazard hazard = ghsdb.Get("H200");

    if (null == hazard)
    {
        uxPictureHazardPictogram.Image = null;
        uxTextClassValue.Text = string.Empty;
        uxTextCategoryValue.Text = string.Empty;
        uxTextSignalWordValue.Text = string.Empty;
        uxTextPhraseValue.Text = string.Empty;
        uxTextPCodesValue.Text = string.Empty;
    }
    else
    {
        MemoryStream ms = new MemoryStream(hazard.PictogramImage);
        uxPictureHazardPictogram.Image = Image.FromStream(ms);
        uxPictureHazardPictogram.SizeMode = PictureBoxSizeMode.StretchImage;

        uxTextClassValue.Text = hazard.Class;
        uxTextCategoryValue.Text = string.Join(", ", hazard.Categories);
        uxTextSignalWordValue.Text = hazard.SignalWord;
        uxTextPhraseValue.Text = hazard.Phrase;

        StringBuilder pcodeStatement = new StringBuilder();
        foreach(var pcode in hazard.PCodes)
        {
            pcodeStatement.AppendLine($"{pcode.Code}\t{pcode.Phrase}");
        }
        uxTextPCodesValue.Text = pcodeStatement.ToString();
    }
```
![Example search result](./Resources/ImageSrc/Example/Example.png)
