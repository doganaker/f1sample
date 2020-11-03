const url = "http://ergast.com/api/f1/seasons.json";

export const f1seasonmanager = {

    getseasons: async (limit) => {

        let result = await fetch(url + '?limit=' + limit)
        .then((res) => res.json())
        .then((data) => data.MRData)

        return result;
    }

}
