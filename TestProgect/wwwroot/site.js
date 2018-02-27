$(function () {
    let serverinfo = $('.database').data('serverinfo');

    $.each(serverinfo, function (i, val) {
        let
            database = val.Database, databaseName = val.DatabaseName,
            indexConnectionString = val.IndexConnectionString, isReady = val.IsReady,
            serverName = val.ServerName, sqlClient = val.SqlClient,
            textError = val.TextError;

        /* test */
        console.log(val);
        console.log(database);
        console.log(databaseName);
        console.log(indexConnectionString);
        console.log(isReady);
        console.log(serverName);
        console.log(sqlClient);
        console.log(textError);
        /* /test */
    });
});