# GHSDatabase

A C# in-memory database of hazard codes, phrases, pictograms, labels and other data of the [Globally Harmonised System (GHS)](https://www.hse.gov.uk/chemical-classification/legal/background-directives-ghs.htm) for chemical hazard classification.

## Example Usage

```c#
  IGHSDatabase ghsdb = new GHSDatabase();
  IHazard hazard = ghsdb.Get("H200");

  MemoryStream ms = new MemoryStream(hazard.PictogramImage);
  PictureBox1.Image = Image.FromStream(ms);
  Label1.Text = hazard.Phrase;
```
![Example search result](./Resources/ImageSrc/Example/Example.png)
