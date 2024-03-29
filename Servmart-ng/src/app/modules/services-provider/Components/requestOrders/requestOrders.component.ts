import { Component, OnInit } from '@angular/core';
import { RequestsOrdersService } from '../../services/RequestsOrders/Requests-Orders.service';
import { AuthService } from 'src/app/modules/auth/services/auth/Auth.service';
import { Observable, map } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Component( {
	selector: 'app-requestOrders',
	templateUrl: './requestOrders.component.html',
	styleUrls: [ './requestOrders.component.css' ]
} )
export class RequestOrdersComponent implements OnInit {

	constructor (
		private auth: AuthService,
		private http: HttpClient,
		private reqOrdersService: RequestsOrdersService
	) { }

	ordersList: any[];

	isLoading: boolean;
	currentPage: number = 1;
	pageSize: number = 3;
	totalOrdersItems: number = 0;

	fakeArray = new Array( this.pageSize );

	ngOnInit () {

		// get total items of requests
		this.reqOrdersService.getTotalRequestsOrders( this.auth.getUserValue().userID ).subscribe(
			next => {
				this.totalOrdersItems = next as number;
				console.log( `req orders count: `, this.totalOrdersItems );
			}
		);

		this.getOrders( this.auth.getUserValue().userID, this.currentPage, this.pageSize );
	}

	pageChanged ( event: any ) {
		this.currentPage = event;
		this.getOrders( this.auth.getUserValue().userID, this.currentPage, this.pageSize );
	}

	getOrders ( providerId: string, currentPage: number, pageSize: number ) {
		this.isLoading = true;
		this.reqOrdersService.GetRequestOrders( providerId ).subscribe( {
			next: ( value ) => {
				this.ordersList = value as any[];
				this.isLoading = false;
				console.log( value );
			},
			error: ( value ) => {
				this.isLoading = false;
				console.log( value );
			}
		} );
	}


}
