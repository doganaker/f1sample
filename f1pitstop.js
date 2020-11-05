const url = "https://ergast.com/api/f1/";

export const f1pitstopgmanager = {

    getpitstop: async (year, round, limit) => {

        let result = await fetch(url + year + '/' + round + '/pitstops.json?limit=' + limit)
            .then((res) => res.json())
            .then((data) => data.MRData)

        return result;
    },


    getyears: () => {

        var date = new Date();
        var fullyear = date.getFullYear();
        let years = [];

        for (let i = 2011; i <= fullyear; i++) {
            years.push(i);
        }

        return years;
    },


    getrounds: async (year, limit) => {

        let rounds = await fetch(url + year + '.json?limit=') 
        .then((res) => res.json())
        .then((data) => {
                  
                let totalrounds = data.MRData.total;
                return totalrounds;
            });

        let returnrounds = [];

        for (let i = 1; i <= rounds; i++) {
            returnrounds.push(i);
        }

        return returnrounds;
    }

}