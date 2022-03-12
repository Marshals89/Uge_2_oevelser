using Pew.Models;
using RestSharp;

namespace Pew
{
    public class StarWarsLogic
    {
        private static readonly string baseUri = "https://swapi.dev/api";

        public async Task<StarWarsPeopleResponse> GetPeople(int page)
        {
            string uri = string.Format("{0}/{1}{2}", baseUri, "people?page=", page);
            return await ApiClient.Execute<StarWarsPeopleResponse>(Method.Get, uri);
        }

        public async Task<StarWarsPlanetsResponse> GetPlanets(int page)
        {
            string uri = string.Format("{0}/{1}{2}", baseUri, "planets?page=", page);
            return await ApiClient.Execute<StarWarsPlanetsResponse>(Method.Get, uri);
        }
    }
}