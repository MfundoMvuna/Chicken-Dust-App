using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Chicken_Dust.BusLogic;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Chicken_Dust_App.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly CalculateDistance _calculateDistance;

    public IndexModel(CalculateDistance calculateDistance)
    {
        _calculateDistance = calculateDistance;
    }

    public async Task OnGet()
    {
        const string apiKey = "AldDeg0uDUfQ9OITnYGSC-COvpo6K6zgH5_JIdOG3Om6tvTvVTwhPYia__j5jHJf"; // Your Bing Maps API key

        // Example usage of Distance method
        string userLatitude = "-29.7374565";
        string userLongitude = "30.9430011";
        string destinationLatitude = "-29.7252749";
        string destinationLongitude = "31.0669645";

        string origins = $"{userLatitude},{userLongitude}";
        string destinations = $"{destinationLatitude},{destinationLongitude}";

        string apiUrl = $"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins={origins}&destinations={destinations}&travelMode=driving&key={apiKey}";

        string result = await _calculateDistance.Distance(origins,destinations);
        string distanceInTime = await _calculateDistance.DistanceAway(origins, destinations);
        //string result = await _calculateDistance.Distance(destinationAddress, destinationLocation, userAddress, userLocation);

        // Use the result as needed, for example, store it in ViewData
        ViewData["DistanceResult"] = result;
        ViewData["DistanceTimeResult"] = distanceInTime;
    }
}
