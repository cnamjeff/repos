function Initialisation() {
    //gère les options des datepickers
    $('#datetimepicker6').datetimepicker({
        format: "YYYY-MM-DD HH:mm:ss",  
        showTodayButton: true,
        locale: 'fr',        
        useCurrent: true
    });

    $('#datetimepicker7').datetimepicker({
        format: "YYYY-MM-DD HH:mm:ss",      
        showTodayButton: true,    
        locale: 'fr',
        useCurrent: true       
    });
    // récupère la valeur du datetimepicker6 qui correspond a la date minimum
    $("#datetimepicker6").on("dp.change", function (e) {
        $('#datetimepicker7').data("DateTimePicker").minDate(e.date);
        
    });
    // récupère la valeur du datetimepicker7 qui correspond a la date maximum
    $("#datetimepicker7").on("dp.change", function (e) {
        $('#datetimepicker6').data("DateTimePicker").maxDate(e.date);
        window.table.fnDraw();
    });
    // récupère la valeur du champ type de status
    $("#state").on("change", function (e) {
       
        window.table.fnDraw();
    });

    
    window.table = $('#login').dataTable({
        "processing":
            true,
        "serverSide":
            true,
        "ajax":
        {//url que l'on retrouve dans la section script de la page VueLogin
            "url":window.ListingHandler,
        "type":
            "POST",
        "contentType":
            "application/json; charset=utf-8",
        "data":
            function (data) {
                //gère la date minimum
                data.MinDate = $("input[id=datetimepicker6]").val();
                //gère la date maximum
                data.MaxDate = $("input[id=datetimepicker7]").val();
                //gère le type de Status
                data.Etat = $("select[id=state]").val();
                            
                return data = JSON.stringify(data);
            }
    },
    "createdRow":
    function (row, data, Index) {
        //détermine la couleur d'une ligne quand la colonne 5 est égale à Rejected
        if (data[4] === "Rejected") {
            $('td', row).eq(4).html(data[4]).addClass("warning");
            $('td', row).eq(3).html(data[3]).addClass("warning");
            $('td', row).eq(2).html(data[2]).addClass("warning");
            $('td', row).eq(1).html(data[1]).addClass("warning");
            $('td', row).eq(0).html(data[0]).addClass("warning");
        }
        //détermine la couleur d'une ligne quand la colonne 5 est égale à BlockedByLogin
        if (data[4] === "BlockedByLogin") {
            $('td', row).eq(4).html(data[4]).addClass("success");
            $('td', row).eq(3).html(data[3]).addClass("success");
            $('td', row).eq(2).html(data[2]).addClass("success");
            $('td', row).eq(1).html(data[1]).addClass("success");
            $('td', row).eq(0).html(data[0]).addClass("success");
        }
        //détermine la couleur d'une ligne quand la colonne 5 est égale à BlockedByIp
        if (data[4] === "BlockedByIp") {
            $('td', row).eq(4).html(data[4]).addClass("danger");
            $('td', row).eq(3).html(data[3]).addClass("danger");
            $('td', row).eq(2).html(data[2]).addClass("danger");
            $('td', row).eq(1).html(data[1]).addClass("danger");
            $('td', row).eq(0).html(data[0]).addClass("danger");
        }
        //détermine la couleur d'une ligne quand la colonne 5 est égale à Authorized
        if (data[4] === "Authorized") {
            $('td', row).eq(4).html(data[4]).addClass("active");
            $('td', row).eq(3).html(data[3]).addClass("active");
            $('td', row).eq(2).html(data[2]).addClass("active");
            $('td', row).eq(1).html(data[1]).addClass("active");
            $('td', row).eq(0).html(data[0]).addClass("active");
        }
    }
});



}



