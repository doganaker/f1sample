import { f1pitstopgmanager } from '/js/f1pitstop.js'


let years = f1pitstopgmanager.getyears();
for (let i = 0; i < years.length; i++) {
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}


f1pitstopgmanager.getrounds(2011)
    .then((rounds) => {

        for (let i = 0; i < rounds.length; i++) {
            $('#roundsselect').append(
                `<option>` + rounds[i] + `</option>`
            )
        }
    });

let firstyear = 2011;
let firstround = 1;
let limit = 100;


f1pitstopgmanager.getpitstop(firstyear, firstround, limit)
    .then((data) => {

        appendmanager.appendtable(data.RaceTable.Races[0]);
    })


const appendmanager = {

    appendtable: (data) => {

        $('tbody tr').remove();
        $('#racename th').remove();

        $('#racename').append(
            '<th>' + data?.raceName + '</th>'
        )
      
        data.PitStops.forEach(element => {

            $('tbody').append(
                `<tr>
                    <td>` + element.driverId + `</td>
                    <td>` + element.lap+ `</td>
                    <td>` + element.stop+ `</td>
                    <td>` + element.time + `</td>
                    <td>` + element.duration + `</td>
                </tr>`
            )
        });
        $(document).ready(function () {
            $('#lb').DataTable();
        });
    }
}

$('#yearsselect').change(function () {
    $('#roundsselect option').remove();

    let selectedyearid = $('#yearsselect').val();

    f1pitstopgmanager.getrounds(selectedyearid)
        .then((rounds) => {

            for (let i = 0; i < rounds.length; i++) {
                $('#roundsselect').append(
                    `<option>` + rounds[i] + `</option>`
                )
            }
        });

        f1pitstopgmanager.getpitstop(selectedyearid, firstround, limit)
        .then((data) => {

            appendmanager.appendtable(data.RaceTable.Races[0]);
        })
})




$('select').change(function () {

    let selectedyearid = $('#yearsselect').val();
    let selectedroundid = $('#roundsselect').val();

    f1pitstopgmanager.getpitstop(selectedyearid, selectedroundid, limit)
        .then((data) => {

            appendmanager.appendtable(data.RaceTable.Races[0]);
        })
})

