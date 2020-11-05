const url = "https://ergast.com/api/f1/";


export const f1raceschedulemanager = {

    getschedule: async (year) => {

        let result = await fetch(url + year + '.json')
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
    },


    getrounds: async (year) => {

        let rounds = await f1raceschedulemanager.getschedule(year)
            .then((res) => {

                let totalrounds = res.total;
                return totalrounds;
            });

        let returnrounds = [];

        for (let i = 1; i <= rounds; i++) {
            returnrounds.push(i);
        }

        return returnrounds;
    }

}





