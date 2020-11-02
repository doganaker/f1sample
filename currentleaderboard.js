const url = "https://ergast.com/api/f1/2020/driverStandings.json";


 export const lbmanager = {

    getleader : async () => {

        let result = await fetch(url)
        .then((res) => res.json())
        .then((data) => data.MRData)

        return result;
    }
}



