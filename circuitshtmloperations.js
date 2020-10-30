import { f1circuitsmanager } from './circuits.js';


//Yılları getir
let years = f1circuitsmanager.getyears();
for(let i = 0; i < years.length; i++){
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}

let firstyear = 1950;

f1circuitsmanager.getcirciuts(firstyear).then((data) => {

    appendmanager.appendtable(data.CircuitTable.Circuits);
})


const appendmanager = {

    appendtable: (data) => {

        $('tbody tr').remove();
        data.forEach(element => {

            $('tbody').append(
                `<tr>
                    <td id="` + element.circuitId + `">` + element.circuitId + `</td>
                    <td>`+ element.circuitName + `</td>
                    <td>` + element.Location.locality + `</td>
                    <td>`+ element.Location.country + `</td>
                    <td><a href=` + element.url + `target = '_blank'>` + element.url + `</a></td>
                </tr>`
            )
        });
    }
}

//Yıl select
$('select').change(function(){

    let selectedyearid = $('#yearsselect').val();
    f1circuitsmanager.getcirciuts(selectedyearid).then((data)=>{
        appendmanager.appendtable(data.CircuitTable.Circuits);
    })
})
