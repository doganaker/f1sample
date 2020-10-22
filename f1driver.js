const url = "https://ergast.com/api/f1/drivers.json";

export const drivermanager = {

    getdrivers: async (limit) => {
        let outcome = await fetch(url + '?limit=' + limit)
            .then((res) => res.json())
            .then((data) => data.MRData)

        return outcome;
    }
}