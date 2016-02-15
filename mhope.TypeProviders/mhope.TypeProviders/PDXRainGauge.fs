namespace mhope.TypeProviders

module PDXRainGauge =

    open FSharp.Data
    open System

    type RainData = {
        StationName: string;
        StationNumber: string;
        _1DayAccumulation: string;
        _3DayAccumulation: string;
        _5DayAccumulation: string;
        CurrentMonthAccumulation: string;
        WaterYearAccumulation: string
        }
        

    //declare the type
    type pdxRainProvider = HtmlProvider<"http://or.water.usgs.gov/non-usgs/bes/">

    //load the html
    let pdxRainData = pdxRainProvider.Load("http://or.water.usgs.gov/non-usgs/bes/")

 
    let pdxRainfallRecords =
         let rows = 
            pdxRainData.Tables.``City of Portland HYDRA Rainfall Network 2``.Rows
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.ToLower().Contains("region")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.Contains("Station Name")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.ToLower().Contains("portland area")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.ToLower().Contains("other")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages 3``.ToLower().Contains("was retired")))
         seq {
            for row in rows do
            yield {
                    StationName = row.``City of Portland Rain Gages``;
                    StationNumber = row.``City of Portland Rain Gages 2``;
                    _1DayAccumulation = row.``City of Portland Rain Gages 4``;
                    _3DayAccumulation = row.``City of Portland Rain Gages 5``;
                    _5DayAccumulation = row.``City of Portland Rain Gages 6``;
                    CurrentMonthAccumulation = row.``City of Portland Rain Gages 7``;
                    WaterYearAccumulation = row.``City of Portland Rain Gages 8``
                }
            }

    pdxRainfallRecords
    |> Seq.iter (fun row -> printfn "Station: %s \r   Number: %s \r      MTD Rainfall: %s" row.StationName row.StationNumber row.CurrentMonthAccumulation)
   


   
   

    




    


