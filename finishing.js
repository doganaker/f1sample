const url = "https://ergast.com/api/f1/";

export const f1finishmanager = {

    getstatus: async () => {

        let result = await fetch(url + 'status.json')
            .then((res) => res.json())
            .then((data) => data.MRData)

        return result;
    },

    getstatuswithyear: async (year) => {

        let result = await fetch(url + year + '/status.json')
            .then((res) => res.json())
            .then((data) => data.MRData)

        return result;
    },

    getyears: () => {
        var date = new Date();
        var fullyear = date.getFullYear();
        let years = [];
        years.push('Yıl Seçiniz');
        for (let i = 1950; i <= fullyear; i++) {
            
            years.push(i);
        }

        return years;
    }
}


