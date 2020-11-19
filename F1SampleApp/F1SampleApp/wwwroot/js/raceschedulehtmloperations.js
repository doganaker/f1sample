import { f1raceschedulemanager } from '/js/f1raceschedule.js'


let years = f1raceschedulemanager.getyears();
for (let i = 0; i < years.length; i++) {
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}


let firstyear = 1950;

f1raceschedulemanager.getschedule(firstyear)
    .then((data) => {

        appendmanager.appendtable(data.RaceTable.Races);
    })


const appendmanager = {

    appendtable: (data) => {

        $('tbody tr').remove();

        data.forEach(element => {

            $('tbody').append(
                `<tr>
                    <td>` + element.round + `</td>
                    <td>` + element.raceName + `</td>
                    <td>` + element.date + `</td>
                    <td>` + element.Circuit.circuitName + `</td>
                    <td>` + element.Circuit.Location.country + `</td>
                    <td>` + element.url + `</td>
               
                </tr>`
            )
        });

        $(document).ready(function () {
            $('#lb').DataTable();
        });
    }
}


$('select').change(function () {

    let selectedyearid = $('#yearsselect').val();

    f1raceschedulemanager.getschedule(selectedyearid)
        .then((data) => {

            appendmanager.appendtable(data.RaceTable.Races);
        })
})

