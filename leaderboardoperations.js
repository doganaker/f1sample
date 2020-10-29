import {leadermanager} from "./leaderboard.js";

leadermanager.getleader(10).then((data) => {
    appendmanager.appendtable(data.StandingsTable.StandingsLists[0].DriverStandings)
})


const appendmanager = {

    appendtable: (data) => {

        data.forEach(element => {

            console.log(element.position);
            console.log(element.Driver.givenName + ` ` + element.Driver.familyName);
            console.log(element.points);
            console.log(element.wins);
            console.log(element.Constructors[0].name);

            $("tbody").append(

                `<tr>
                    <td>` + element.position + `</td>
                    <td>` + element.Driver.givenName + ` ` + element.Driver.familyName + `</td>
                    <td>` + element.points + `</td>
                    <td>` + element.wins + `</td>
                    <td>` + element.Constructors[0].name + `</td>
                </tr>`
            );
        })
    }
}
