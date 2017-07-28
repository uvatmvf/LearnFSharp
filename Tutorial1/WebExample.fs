open System.Net
open System
open System.IO

let fetchUrl callback url = 
    let req = WebRequest.Create(Uri(url))
    use resp = req.GetResponse()
    use stream = resp.GetResponseStream()
    use reader = new IO.StreamReader(stream)
    callback reader url

let myCallback (reader:IO.StreamReader) url = 
    let html = reader.ReadToEnd()
    let html1000 = html.Substring(0,1000)
    printfn "Downloaded %s. First 1000 is %s" url html1000
    html 

let git = fetchUrl myCallback "http://github.com"

let bakedInUrlFetch = fetchUrl myCallback
let google = bakedInUrlFetch "http://www.google.com"
let cnn = bakedInUrlFetch "http://www.cnn.com"

let websites = ["http://www.stackoverflow.com"; 
                "http://www.microsoft.com";
                "http://www.gmail.com";
                "http://www.foobar2.com"] // will throw error

websites |> List.map bakedInUrlFetch

// C# Equivalent of opening a url and calling back with resource
//class WebPageDownloader
//{
//    public TResult FetchUrl<TResult>(
//        string url,
//        Func<string, StreamReader, TResult> callback)
//    {
//        var req = WebRequest.Create(url);
//        using (var resp = req.GetResponse())
//        {
//            using (var stream = resp.GetResponseStream())
//            {
//                using (var reader = new StreamReader(stream))
//                {
//                    return callback(url, reader);
//                }
//            }
//        }
//    }
//}

//[Test]
//public void TestFetchUrlWithCallback()
//{
//    Func<string, StreamReader, string> myCallback = (url, reader) =>
//    {
//        var html = reader.ReadToEnd();
//        var html1000 = html.Substring(0, 1000);
//        Console.WriteLine(
//            "Downloaded {0}. First 1000 is {1}", url,
//            html1000);
//        return html;
//    };

//    var downloader = new WebPageDownloader();
//    var google = downloader.FetchUrl("http://www.google.com",
//                                      myCallback);
            
//    // test with a list of sites     var sites = new List<string> {
//        "http://www.bing.com",
//        "http://www.google.com",
//        "http://www.yahoo.com"};

//    // process each site in the list     sites.ForEach(site => downloader.FetchUrl(site, myCallback));
//}