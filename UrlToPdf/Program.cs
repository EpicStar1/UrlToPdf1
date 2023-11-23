using UrlToPdf;

var pdfService = new PdfService();

string[] urls = new string[] {
    "https://docs.plex.com/pmc/en-us/engineering/parts/adding-and-editing-parts.htm",
    "https://docs.plex.com/pmc/en-us/engineering/parts/copying-parts.htm",
    "https://docs.plex.com/pmc/en-us/engineering/parts/specifying-part-attributes.htm",
    "https://docs.plex.com/pmc/en-us/engineering/parts/viewing-part-information.htm"
};

string[] urls1 = new string[] {
    "https://www.plex.com/smart-manufacturing-platform",
    "https://www.plex.com/products/manufacturing-execution-system",
    "https://www.plex.com/industries/food-and-beverage/why-mes-critical-food-and-beverage-manufacturers",
    "https://www.plex.com/products/asset-performance-management/apm-guide"
};

//Enter your Azure AD App Client ID:
string clientId = "";

//Enter your Azure AD App Client Secret:
string clientSecret = "";

//Enter your Azure AD Tenant ID:
string tenantId = "";

try
{
    int counter = 1;
    foreach (var url in urls)
    {
        string fileName = "Page_" + counter + ".pdf";
        string filePath = System.IO.Path.Combine("C:\\AmitPandey\\source\\repos\\GPTindex\\docs", fileName);

        await pdfService.ConvertHtmlToPdf(url, filePath);

        counter += 1;
    }

    Console.WriteLine("URL Scrapped Successfully!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

