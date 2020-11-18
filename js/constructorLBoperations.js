import {leadermanager} from "./constructorLB.js"


leadermanager.getconstructors().then((data) => {

    appendmanager.appendtable(data.StandingsTable.StandingsLists[0].ConstructorStandings)
})




const appendmanager = {

    appendtable: (data) => {

        data.forEach(element => {

            $('tbody').append(`
                <tr>
                    <td>` + element.position + `</td>
                    <td>` + element.Constructor.name + `</td>
                    <td>` + element.points + `</td>
                    <td>` + element.wins + `</td>
                    <td><a href="` + element.Constructor.url + `">` + element.Constructor.url + `</a></td>
                </tr>`
            );
        })
    }
        
    }
