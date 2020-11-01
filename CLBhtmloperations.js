import {lbmanager} from './currentleaderboard.js'

lbmanager.getleader().then((data) => {

    appendmanager.appendtable(data.StandingsTable.StandingsLists[0].DriverStandings)
})


const appendmanager = {

    appendtable : (data) =>{

        data.forEach(element => { 

            $('tbody').append(`
                <tr>
                    <td>` + element.position + `</td>
                    <td id="gotopage"><a href="`+ element.Driver.givenName.toLowerCase() + element.Driver.familyName.toLowerCase() +`.html" class="text-decoration-none" target="_blank">` + element.Driver.givenName + ` ` + element.Driver.familyName + `</a></td>
                    <td>` + element.Driver.nationality + `</td>
                    <td>` + element.Driver.permanentNumber + `</td>
                    <td>` + element.points + `</td>
                    <td>` + element.wins + `</td>
                    <td>` + element.Constructors[0].name + `</td>
                </tr>`
            );
        })
    }
}