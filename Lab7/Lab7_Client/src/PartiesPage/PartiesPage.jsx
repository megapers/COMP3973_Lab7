import React from 'react';

import { partyService } from '@/_services';

class PartiesPage extends React.Component {
    constructor(props) {
        super(props);
        this.state = {data: []};
        this.arr = [];
    }

    componentDidMount() {
        partyService.getAllParties()
        .then((response) => {
            let data = [];
            response.forEach(element => {
                data.push(element);
                this.arr.push(element);
            }); 
            this.setState({ data });
        });
        
    }

    renderTableData() {
        console.log(this.arr);
        return this.state.data.map((party, index) => {
           const { partyId, partyName, partyDate, expectedNumberOfGuests, location } = party //destructuring
           return (
              <tr key={partyId}>
                 <td>{partyId}</td>
                 <td>{partyName}</td>
                 <td>{partyDate}</td>
                 <td>{expectedNumberOfGuests}</td>
                 <td>{location}</td>
              </tr>
           )
        });
     }

     renderTableHeader() {
        if (!this.state.data === undefined || !this.state.data.length == 0){
        let header = Object.keys(this.state.data[0])
        return header.map((key, index) => {
           return <th key={index}>{key.toUpperCase()}</th>
        });
        console.log(this.state);
        }
    }
    
     render() {
        return (
           <div>
              <h3 id='title'>My Parties</h3>
              <table id='parties'>
                 <tbody>
                 <tr>{this.renderTableHeader()}</tr>
                  {this.renderTableData()}
                 </tbody>
              </table>
           </div>
        );
    }
}

export { PartiesPage };