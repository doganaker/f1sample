const url = "http://ergast.com/api/f1/";

export const f1circuitsmanager = {

    getcirciuts: async (year) => {

        let result = await fetch(url + year + '/circuits.json')
            .then((res) => res.json())
            .then((data) => data.MRData)

        return result;
    },

    getyears: () => {
        var date = new Date();
        var fullyear = date.getFullYear();
        let years = [];
        for (let i = 1950; i <= fullyear; i++) {

            years.push(i);
        }

        return years;
    }
}


