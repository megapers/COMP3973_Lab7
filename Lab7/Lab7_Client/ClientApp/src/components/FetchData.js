import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { parties: [], loading: true };
  }

  componentDidMount() {
    this.populatePartiesData();
  }

  static renderPartiesTable(parties) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Date</th>
            <th>No of guests</th>
            <th>Location</th>
          </tr>
        </thead>
        <tbody>
          {parties.map(party =>
            <tr key={party.id}>
              <td>{party.partyName}</td>
              <td>{party.partyDate}</td>
              <td>{party.expectedNumberOfGuests}</td>
              <td>{party.location}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderPartiesTable(this.state.parties);

    return (
      <div>
        <h1 id="tabelLabel" >List of parties</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populatePartiesData() {
    const response = await fetch('https://localhost:5001/api/Parties/GetAllParties');
    const data = await response.json();
    this.setState({ parties: data, loading: false });
  }
}
