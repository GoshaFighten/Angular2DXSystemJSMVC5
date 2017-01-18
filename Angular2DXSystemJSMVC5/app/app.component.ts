import { Component } from '@angular/core';

let AspNetData = require('devextreme-aspnet-data');

@Component({
    selector: 'my-app',
    templateUrl: 'app/app.component.html'
})
export class AppComponent {
    store = AspNetData.createStore({
        key: 'OrderID',
        loadUrl: 'api/SampleData/Orders',
        insertUrl: 'api/SampleData/AddOrder',
        updateUrl: 'api/SampleData/UpdateOrder',
        deleteUrl: 'api/SampleData/DeleteOrder'
    });
    countryStore = AspNetData.createStore({
        key: "CountryName",
        loadUrl: 'api/SampleData/Countries',
    });
    setShipCountryValue(rowData: any, value: any): void {
        rowData.ShipCity = null;
        (<any>this).defaultSetCellValue(rowData, value);
    }
    getCityStore(options: any): any {
        let dataSourceConfiguration: any = {
            store: AspNetData.createStore({
                key: "CityName",
                loadUrl: 'api/SampleData/Cities',
            })
        };
        if (options.data) {
            dataSourceConfiguration.filter = ['Country', '=', options.data.ShipCountry];
        }
        return dataSourceConfiguration;
    }
}
