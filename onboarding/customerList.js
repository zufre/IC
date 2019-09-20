import React from 'react';
import ModalCreate from './ModalCreate';
import {Button, Icon, Menu, Table, Pagination } from 'semantic-ui-react';
import axios from 'axios';


class CustomerList extends React.Component {
    constructor(props) {
        super(props);
        this.state = { customers: [] };

        axios.get('/Customers/GetCustomers', )
            .then(res => {
                const customers = res.data;
            
                this.setState({ customers });
            });
    }


    render() {

        return (
            
            <div>
                <ModalCreate />
                <Table celled striped>
                    <Table.Header>
                        <Table.Row>
                            <Table.HeaderCell>Name</Table.HeaderCell>
                            <Table.HeaderCell>Address</Table.HeaderCell>
                            <Table.HeaderCell>Action</Table.HeaderCell>
                            <Table.HeaderCell>Action</Table.HeaderCell>
                        </Table.Row>
                    </Table.Header>

                    <Table.Body>
                        {this.state.customers.map(customer =>
                            <Table.Row key={customer.Id}>
                                <Table.Cell>{customer.Name}</Table.Cell>

                                <Table.Cell>{customer.Address}</Table.Cell>
                                <Table.Cell><Button color='yellow'  icon ><Icon name='external alternate' /> EDIT</ Button></Table.Cell>
                                <Table.Cell><Button negative icon><Icon name='trash' /> DELETE</Button></Table.Cell>
                        </Table.Row>
                        )}
                         
                    </Table.Body>
                    

                   
                        
                </Table>
          
            </div>
        )
    }

}

export default CustomerList;
