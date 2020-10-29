const url = "http://ergast.com/api/f1/2019/driverStandings.json";

 export const leadermanager = {

    getleader : async () => {

        let result = await fetch(url)
        .then((res) => res.json())
        .then((data) => data.MRData)

        return result;
    }
}
