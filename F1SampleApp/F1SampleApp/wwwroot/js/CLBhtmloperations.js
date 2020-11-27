import {lbmanager} from '/js/currentleaderboard.js'

lbmanager.getleader().then((data) => {

    appendmanager.appendtable(data.StandingsTable.StandingsLists[0].DriverStandings)
})


const appendmanager = {

    appendtable : (data) =>{

        data.forEach(element => { 

            $('tbody').append(`
                <tr>
                    <td>` + element.position + `</td>
                    <td><a href="` + element.Driver.givenName + element.Driver.familyName +`.html" style="text-decoration:none; color:black;" >` + element.Driver.givenName + ` ` + element.Driver.familyName + `</a></td>
                    <td>` + element.Driver.nationality + `</td>
                    <td>` + element.Driver.permanentNumber + `</td>
                    <td>` + element.points + `</td>
                    <td>` + element.wins + `</td>
                    <td>` + element.Constructors[0].name + `</td>
                </tr>`
            );
        })
        $(document).ready(function () {
            $('#lb').DataTable();
        });
    }
}


