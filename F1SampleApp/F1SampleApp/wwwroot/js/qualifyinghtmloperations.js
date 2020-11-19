import { f1qualifyingmanager } from '/js/f1qualifying.js'


let years = f1qualifyingmanager.getyears();
for (let i = 0; i < years.length; i++) {
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}


f1qualifyingmanager.getrounds(1994)
    .then((rounds) => {

        for (let i = 0; i < rounds.length; i++) {
            $('#roundsselect').append(
                `<option>` + rounds[i] + `</option>`
            )
        }
    });

let firstyear = 1994;
let firstround = 1;
let limit = 100;


f1qualifyingmanager.getqualifying(firstyear, firstround, limit)
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

        data.QualifyingResults.forEach(element => {

            $('tbody').append(
                `<tr>
                    <td>` + element.number + `</td>
                    <td>` + element.Driver?.driverId + `</td>
                    <td>` + element.Driver?.givenName + ` ` + element.Driver?.familyName + `</td>
                    <td>` + element.Constructor?.name + `</td>
                    <td>` + element.position + `</td>
                    <td>` + element.Q1 + `</td>
                    <td>` + element.Q2 + `</td>
                    <td>` + element.Q3 + `</td>
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

    f1qualifyingmanager.getrounds(selectedyearid)
        .then((rounds) => {

            for (let i = 0; i < rounds.length; i++) {
                $('#roundsselect').append(
                    `<option>` + rounds[i] + `</option>`
                )
            }
        });

    f1qualifyingmanager.getqualifying(selectedyearid, firstround, limit)
        .then((data) => {

            appendmanager.appendtable(data.RaceTable.Races[0]);
        })
})




$('select').change(function () {

    let selectedyearid = $('#yearsselect').val();
    let selectedroundid = $('#roundsselect').val();

    f1qualifyingmanager.getqualifying(selectedyearid, selectedroundid, limit)
        .then((data) => {

            appendmanager.appendtable(data.RaceTable.Races[0]);
        })
})

