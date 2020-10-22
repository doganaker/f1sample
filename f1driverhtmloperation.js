import {drivermanager} from './f1driver.js'

drivermanager.getdrivers(100).then((data) =>{
    appendmanager.appendtable(data.DriverTable.Drivers)
})


const appendmanager = {

    appendtable: (data) => {

        $("tbody tr").remove();
        data.forEach(element => {
            $('tbody').append(
                `<tr>
                    <td>` + element.driverId + `</td>
                    <td> ` + element.givenName + ` ` + element.familyName + `</td>
                    <td>` + element.dateOfBirth + `</td>
                    <td>` + element.nationality + `</td>
                    <td><a href='` + element.url + `' target = '_blank'>` + element.url +`</a></td>`
            )
        });
    }
}

$('#searchbtn').click(function(){

    let inp = $('#inp1').val();

    drivermanager.getdrivers(inp).then((data) =>{
        appendmanager.appendtable(data.DriverTable.Drivers)
    })
})