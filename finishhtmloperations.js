import { f1finishmanager } from './finishing.js';


//Yılları getir
let years = f1finishmanager.getyears();
for(let i = 0; i < years.length; i++){
    $('#yearsselect').append(
        `<option>` + years[i] + `</option>`
    )
}

let firstyear = 0;

f1finishmanager.getstatus().then((data) => {

    appendmanager.appendtable(data.StatusTable.Status);
})


const appendmanager = {

    appendtable: (data) => {

        $('tbody tr').remove();
        data.forEach(element => {

            $('tbody').append(
                `<tr>
                    <td id="` + element.statusId + `">` + element.statusId + `</td>
                    <td>`+ element.count + `</td>
                    <td>` + element.status + `</td>
                </tr>`
            )
        });
    }
}

//Yıl select
$('select').change(function(){

    let selectedyearid = $('#yearsselect').val();
    f1finishmanager.getstatuswithyear(selectedyearid).then((data)=>{
        appendmanager.appendtable(data.StatusTable.Status);
    })
})
