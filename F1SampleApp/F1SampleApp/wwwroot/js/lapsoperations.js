import { f1lapsmanager } from '/js/laps.js'


//Yılları getir
// 1996 ve sonrası var Select içinde sadece 1996 ve sonrası gelmeli

let years = f1lapsmanager.getyears();
for (let i = 0; i < years.length; i++) {
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}

// Turları getir
for (let i = 1; i < 70; i++) {
    $('#tourselect').append(
        `<option>` + i + `</option>`
    )
}


//Roundları getir
for (let i = 1; i < 23; i++) {
    $('#roundsselect').append(
        `<option>` + i + `</option>`
    )
}

let firstyear = 1996;
let firstround = 1;
let tour = 1;


f1lapsmanager.getlaps(firstyear, firstround, tour).then((data) => {

    appendmanager.appendtable(data.RaceTable.Races[0].Laps[0].Timings);
})

const appendmanager = {

    appendtable: (data) => {

        $('tbody tr').remove();

        data.forEach(element => {

            $('tbody').append(
                `<tr>
                    <td>` + element.driverId + `</td >
                    <td>` + element.position + `</td>
                    <td>` + element.time + `</td>
                </tr>`
            )
        });

        $(document).ready(function () {
            $('#lb').DataTable();
        });
    }
}


//Year, round ve tour select
$('select').change(function () {

    let selectedyearid = $('#yearsselect').val();
    let selectedroundid = $('#roundsselect').val();
    let selectedtourid = $('#tourselect').val();
    f1lapsmanager.getlaps(selectedyearid, selectedroundid, selectedtourid).then((data) => {
        appendmanager.appendtable(data.RaceTable.Races[0].Laps[0].Timings);
    })
})

