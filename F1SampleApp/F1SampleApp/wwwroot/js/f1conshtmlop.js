import {consmanager} from '/js/f1.js'

consmanager.getraces(100).then((data) => {
    appendmanager.appendtable(data.ConstructorTable.Constructors);
});

const appendmanager = {

    appendtable: (data) => {

            $('tbody tr').remove();
            data.forEach(element => {

                $("tbody").append(
                    `<tr>
                        <td>`+ element.constructorId + `</td>
                        <td>`+ element.name +`</td>
                        <td>`+ element.nationality + `</td>
                    </tr>`
                )
            });
        $(document).ready(function () {
            $('#lb').DataTable();
        });
    }
}