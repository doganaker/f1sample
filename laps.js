const url = "https://ergast.com/api/f1/";

export const f1lapsmanager = {

    getlaps: async (year,round,tour) => {

        let result = await fetch(url + year + '/' + round + '/laps/' + tour + '.json') 
        .then((res) => res.json())
        .then((data) => data.MRData)
        console.log(result)
        return result;
    },

    

    getyears: () => {
        var date = new Date();
        var fullyear = date.getFullYear();
        let years = [];
        for(let i = 1996; i <= fullyear; i++){

            years.push(i);
        }

        return years;
    },

    getrounds: async (year,tour) => {

        let rounds = await f1lapsmanager.getlaps(year,1,tour).then((res) => {

            let totalrounds = res.total;
            return totalrounds;
        });

        let returnrounds = [];
        for(let i = 1; i <= rounds; i++){
            returnrounds.push(i);
        }
        return returnrounds;
    },

    gettours: async (year,rounds) => {

        let returntours = [];
        for(let i = 1; i <= 70; i++){
            returntours.push(i);
        }
        return returntours;
    }



    
}