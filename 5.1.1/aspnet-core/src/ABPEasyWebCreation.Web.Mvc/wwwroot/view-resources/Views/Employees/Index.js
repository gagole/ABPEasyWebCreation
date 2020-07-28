(function () {
    $(function () {
        
        $("#gridContainer").dxDataGrid({
            remoteOperations: true,
            dataSource: {
                store: DevExpress.data.AspNet.createStore({
                    key: "id",
                    loadUrl: "http://localhost:62114/api/EmployeesApi/GetAll",
                    insertUrl: "http://localhost:62114/api/EmployeesApi/Post",
                    updateUrl: "http://localhost:62114/api/EmployeesApi/Put",
                    deleteUrl: "http://localhost:62114/api/EmployeesApi/Delete"
                })
                
            },
            editing: {
                mode: "popup",
                allowUpdating: abp.auth.isGranted('Pages.Employees.Craete'),
                allowDeleting: abp.auth.isGranted('Pages.Employees.Update'),
                allowAdding: abp.auth.isGranted('Pages.Employees.Delete')
            }, 
            showBorders: true,
            pager: {
                allowedPageSizes: "auto",
                infoText: "Page {0} of {1} ({2} items)",
                showInfo: true,
                showNavigationButtons: true,
                showPageSizeSelector: true,
                visible: true
            },
            paging: {
                enabled: true,
                pageIndex: 0,
                pageSize: 20
            },
            scrolling: {
                mode: "standard"
            },
            columns: ["fullName", "nick", "staffNo", "startingDate", "mobile","email"]
        });

    });
})();