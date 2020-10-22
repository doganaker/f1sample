import {f1seasonmanager} from './season.js';

f1seasonmanager.getseasons(100).then((data) => {

    appendmanager.appendtable(data.SeasonTable.Seasons);
})

const appendmanager = {

    appendtable: (data) => {

        // $('tbody tr').remove();
        data.forEach(element =>{

            $('tbody').append(
                `<tr>
                    <td id="` + element.season +`">` + element.season +`</td>
                    <td><a href=` + element.url +`target = '_blank'>`+ element.url +`</a></td>
                </tr>`
            )
        });
    }
}

$(document).on("click", "td", function () {
    var seasonid = $(this).attr("id");
    localStorage.setItem("season",seasonid);
    window.open('seasondetail.html','_blank');
})
 

