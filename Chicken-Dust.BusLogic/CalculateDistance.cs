﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Chicken_Dust.BusLogic
{
    public class CalculateDistance : IDistance
    {
        private const string apiKey = "AldDeg0uDUfQ9OITnYGSC-COvpo6K6zgH5_JIdOG3Om6tvTvVTwhPYia__j5jHJf"; // Your Bing Maps API key

        public async Task<string> Distance(string address, string origins)
        {
            // Construct your Bing Maps API Distance Matrix request here
            string apiUrl = $"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins={origins}&destinations={address}&travelMode=driving&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response and extract distance information
                    string responseBody = await response.Content.ReadAsStringAsync();
                    double distance = ParseDistanceFromJson(responseBody);

                    // Assign the distance to the field if needed
                    // this.distance = distance;

                    return $"It's {distance} meters away";
                }
                else
                {
                    throw new Exception($"Failed to retrieve distance: {response.ReasonPhrase}");
                }
            }
        }

        public async Task<string> DistanceAway(string address, string location, string myaddress, string mylocale)
        {
            // Construct your Bing Maps API Distance Matrix request here
            string apiUrl = $"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins={myaddress}&destinations={address}&travelMode=driving&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Parse the response and extract distance information
                    string responseBody = await response.Content.ReadAsStringAsync();
                    double distance = ParseDistanceFromJson(responseBody);

                    // Assign the distance to the field if needed
                    // this.distance = distance;

                    return $"It's {distance} meters away";
                }
                else
                {
                    throw new Exception($"Failed to retrieve distance: {response.ReasonPhrase}");
                }
            }
        }

        // Implement a method to parse distance from the Bing Maps API JSON response
        private double ParseDistanceFromJson(string jsonResponse)
        {
            // Implement logic to parse JSON and extract distance information

            try
            {
                // Parse the JSON response using Newtonsoft.Json
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);

                // Assuming the distance is in meters, you might need to navigate the JSON structure
                // to find the appropriate field containing the distance information.
                // This example assumes that the distance is in the 'resourceSets[0].resources[0].results[0].travelDistance' field.
                double distance = json.resourceSets[0].resources[0].results[0].travelDistance;

                return distance;
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                // Handle JSON parsing errors
                throw new Exception("Error parsing JSON response", ex);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                throw new Exception("Error processing JSON response", ex);
            }
        }

    }
}
