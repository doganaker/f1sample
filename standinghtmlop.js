import {f1manager} from './f1standing.js'


//Yılları getir
let years = f1manager.getyears();
for(let i = 0; i < years.length; i++){
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}

//Roundları getir
f1manager.getrounds(1950).then((rounds) =>{

    for(let i = 0; i < rounds.length; i++){
        $('#roundsselect').append(
            `<option>` + rounds[i] + `</option>`
        )
    }
});


let firstyear = 1950;
let firstround = 1;
let limit = 100;


f1manager.getstanding(firstyear,firstround,limit).then((data) => {

    appendmanager.appendtable(data.StandingsTable.StandingsLists[0].DriverStandings);
})


const appendmanager = {

    appendtable: (data) => {

        $('tbody tr').remove();
        data.forEach(element => {
            $('tbody').append(
                `<tr>
                    <td>` + element.Driver?.driverId + `</td>
                    <td>` + element.Driver?.givenName + ` ` + element.Driver?.familyName + `</td>
                    <td>` + element.Driver?.nationality + `</td>
                    <td><a href='` + element.Driver?.url + `' target = '_blank'>` + element.Driver?.url + `</a></td>
                    <td>` + element.position + `</td>
                    <td>` + element.points + `</td>
                    <td>` + element.wins + `</td>
                    <td>` + element.Constructors[0]?.name + `</td>
                    <td>` + element.Constructors[0]?.nationality + `</td>
                    <td><a href='` + element.Constructors[0]?.url + `' target = '_blank'>` + element.Constructors[0]?.url + `</a></td>
                </tr>`
                    
            )
        });
    }
}


//Yıl  ve round select
$('select').change(function(){

    let selectedyearid = $('#yearsselect').val();
    let selectedroundid = $('#roundsselect').val();
    f1manager.getstanding(selectedyearid,selectedroundid,limit).then((data)=>{
        appendmanager.appendtable(data.StandingsTable.StandingsLists[0].DriverStandings);
    })
})

//limit search
$('#searchbtn').click(function(){

    let inp = $('#inp1').val();
    let selectedyearid = $('#yearsselect').val();
    let selectedroundid = $('#roundsselect').val();
    f1manager.getstanding(selectedyearid,selectedroundid,inp).then((data) =>{
        appendmanager.appendtable(data.StandingsTable.StandingsLists[0].DriverStandings);
    })
})