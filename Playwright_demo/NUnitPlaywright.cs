using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace Playwright_demo;

public class NUnitPlaywright : PageTest
{
    [SetUp]
    public async Task SetupAsync()
    {
        await Page.GotoAsync(url: "https://allegro.pl");
    }

    [Test]
    public async Task Test1()
    {
        await Page.ClickAsync(selector: "text=Moje Allegro");
        await Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "demo2.jpg"
        });



    }
}
