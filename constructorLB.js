const url = "http://ergast.com/api/f1/2019/constructorStandings.json"

export const leadermanager = {

    getconstructors : async () => {

        let result = await fetch(url)
        .then((res) => res.json())
        .then((data) => data.MRData)

        return result;
    }
}