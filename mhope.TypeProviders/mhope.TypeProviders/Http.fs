namespace mhope.TypeProviders



module HttpTypeProvider =

    open FSharp.Data

    //declare the type
    type pdxRainProvider = HtmlProvider<"http://or.water.usgs.gov/non-usgs/bes/">

    //load the html
    let pdxRainData = pdxRainProvider.Load("http://or.water.usgs.gov/non-usgs/bes/")

   


   
   

    




    


