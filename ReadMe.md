# GHSDatabase

[![Build Status](https://dev.azure.com/techtoniq/GHS%20Database/_apis/build/status/techtoniq.tq-ghsdatabase?branchName=master)](https://dev.azure.com/techtoniq/GHS%20Database/_build/latest?definitionId=36&branchName=master)  [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=GHS&metric=alert_status)](https://sonarcloud.io/dashboard?id=GHS)

A C# in-memory database of hazard codes, phrases, pictograms, labels and other data of the [Globally Harmonised System (GHS)](https://www.hse.gov.uk/chemical-classification/legal/background-directives-ghs.htm) for chemical hazard classification.

## Example Usage

```c#
  IGhsDatabase ghsdb = new GhsDatabase();
  IHazard hazard = ghsdb.Get("H200");

  MemoryStream ms = new MemoryStream(hazard.PictogramImage);
  PictureBox1.Image = Image.FromStream(ms);
  Label1.Text = hazard.Phrase;
```
![Example search result](./Resources/ImageSrc/Example/Example.png)
