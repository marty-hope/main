namespace mhope.TypeProviders

module PDXRainGauge =

    open FSharp.Data
    open System

    type PrecipitationData = {
        StationName: string;
        StationNumber: int;
        _1DayAccumulation: float;
        _3DayAccumulation: float;
        _5DayAccumulation: float;
        CurrentMonthAccumulation: float;
        WaterYearAccumulation: float
        }
        

    //declare the type
    type pdxRainProvider = HtmlProvider<"http://or.water.usgs.gov/non-usgs/bes/">

    //load the html
    let pdxRainData = pdxRainProvider.Load("http://or.water.usgs.gov/non-usgs/bes/")

 
    let pdxRainfallRecords =
        try
         let rows = 
            pdxRainData.Tables.``City of Portland HYDRA Rainfall Network 2``.Rows
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.ToLower().Contains("region")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.Contains("Station Name")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.ToLower().Contains("portland area")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages``.ToLower().Contains("other")))
            |> Array.filter (fun row -> not (row.``City of Portland Rain Gages 3``.ToLower().Contains("was retired")))
         Some(seq {
            for row in rows do
            yield {
                    StationName = row.``City of Portland Rain Gages``;
                    StationNumber = int row.``City of Portland Rain Gages 2``;
                    _1DayAccumulation = float row.``City of Portland Rain Gages 4``;
                    _3DayAccumulation = float row.``City of Portland Rain Gages 5``;
                    _5DayAccumulation = float row.``City of Portland Rain Gages 6``;
                    CurrentMonthAccumulation = float row.``City of Portland Rain Gages 7``;
                    WaterYearAccumulation =  float row.``City of Portland Rain Gages 8``
                }
            })
        with 
            | :? System.FormatException -> printfn "Cast failed."; None
        
            


    
    if Option.isSome pdxRainfallRecords then
        pdxRainfallRecords.Value
        |> Seq.iter (fun row -> printfn "Station: %s \r   Number: %i \r      MTD Rainfall: %f" row.StationName row.StationNumber row.CurrentMonthAccumulation)
   


   
   

    




    


