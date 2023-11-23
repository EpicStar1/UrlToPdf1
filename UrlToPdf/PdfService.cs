using PuppeteerSharp;
using PuppeteerSharp.Media;

namespace UrlToPdf
{
    internal class PdfService
    {
        public async Task ConvertHtmlToPdf(string url, string filePath)
        {
            // Set the path to the Chromium executable (adjust as needed)
            var executablePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            var launchOptions = new LaunchOptions
            {
                Headless = true,
                ExecutablePath = executablePath // Specify the path to Chromium
            };

            var pdfOptions = new PdfOptions
            {
                Landscape = true,
                Format = PaperFormat.Legal

            };

            using (var browser = await Puppeteer.LaunchAsync(launchOptions))
            using (var page = await browser.NewPageAsync())
            {
                await page.GoToAsync(url);
                await page.PdfAsync(filePath, pdfOptions);
            }
        }
    }
}
