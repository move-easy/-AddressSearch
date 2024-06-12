
namespace AddressSearch.AdressesInfo
{
    public static class AddressEndpoint
    {
        public static void AddRouter(this WebApplication app)
        {
            var routerInfo = app.MapGroup("api/info/");
            
            routerInfo.MapGet("{param}", (String param) =>
            {
                if (int.TryParse(param, out _))
                {
                    Cities city = new Cities();
                    var cityData = city.GetCityData();
                    return cityData;
                }
                
                State state = new State(param);
                var stateData = state.GetStateData();
                return stateData;
            });
        }
    }
}
