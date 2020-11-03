const url = "https://ergast.com/api/f1/2019/driverStandings.json?limit=";

 export const leadermanager = {

    getleader : async (limit) => {

        let result = await fetch(url + limit)
        .then((res) => res.json())
        .then((data) => data.MRData)

        return result;
    }
}
