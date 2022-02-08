function Welcome(props) {
    return <h1>Hello, {props.name}</h1>;
}
class SearchPeople extends React.Component {

    render() {
        return (
            <div className="row">
                {/* SEARCH LIBRARY */}
                <div className="col-md-4">
                    <div className="card border border-secondary shadow-0">
                        <div className="card-header bg-secondary text-white"><b>Search</b> People<span className="glyphicon glyphicon-search"></span></div>
                        <div className="card-body">
                            <div className="row">
                                <div className="col-md-7">
                                    <label className="form-label">Name</label>
                                    <input className="form-control" placeholder="Enter Name" name="name" type="text"/>
                                </div>
                                <div className="col-md-5">
                                    <label className="form-label">&nbsp;</label>
                                    <div className="btn-toolbar">
                                        <button type="button" className="btn btn-primary form-control">Search</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div></div>
        )
    }
}

class AddPerson extends React.Component {
    render() {
        return(
        <div className="col-md-8">
            <div className="card border border-secondary shadow-0">
                <div className="card-header bg-secondary text-white"><b>New</b> Persona</div>
                <div className="card-body">
                    <div className="row">
                        <div className="col-md-3">
                            <label className="form-label">Name</label>
                            <input className="form-control" placeholder="Enter Name" name="name"  type="text" />
                        </div>
                        <div className="col-md-4">
                            <label className="form-label">Tele</label>
                                <select class="form-select" aria-label="Default select example">
                                    <option selected>Open this select menu</option>
                                    <option value="1">One</option>
                                    <option value="2">Two</option>
                                    <option value="3">Three</option>
                                </select>
                        </div>
                        <div className="col-md-3">
                            <label className="form-label">Telephone</label>
                            <input className="form-control" placeholder="Enter Telephone" name="telephone"  type="text" />
                        </div>
                        <div className="col-md-2">
                            <label className="form-label">&nbsp;</label>
                            <button type="button" className="btn btn-success form-control" >Save</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        )
    }
}
class DisplayPeople extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            persondetail: null,
            namelist: [],
            citylist: [],
            languagelist: [],
            planguagelist: [],
            countrylist: []
        };
    }

    componentDidMount() {
        // Simple GET request using axios
        axios.get('ReactPerson/GetAllPeople')
            .then((response) => {

                var persondata = JSON.parse(response.data);
                var namelist = new Array(persondata.length);
                for (let i = 0; i < persondata.length; i++) {
                    namelist[i] = { Name: persondata[i].Name, Id: persondata[i].Id, CityId: persondata[i].CityId, PhoneNumber: persondata[i].PhoneNumber };
                }
                this.setState({ namelist });
            }
            );
        axios.get('ReactPerson/GetAllCities')
            .then((response) => {

                var getdata = JSON.parse(response.data);
                var citylist = new Array(getdata.length);
                for (let i = 0; i < getdata.length; i++) {
                    citylist[i] = { Name: getdata[i].Name, Id: getdata[i].Id, CountryId: getdata[i].CountryId };
                }
                console.log(citylist);
                this.setState({ citylist });
            }
            );
        axios.get('ReactPerson/GetAllLanguages')
            .then((response) => {

                var getdata = JSON.parse(response.data);
                var languagelist = new Array(getdata.length);
                for (let i = 0; i < getdata.length; i++) {
                    languagelist[i] = { Name: getdata[i].Name, Id: getdata[i].Id };
                }
                this.setState({ languagelist });
            }
            );
        axios.get('ReactPerson/GetAllPersona_Languages')
            .then((response) => {

                var getdata = JSON.parse(response.data);
                var planguagelist = new Array(getdata.length);
                for (let i = 0; i < getdata.length; i++) {
                    planguagelist[i] = { PersonaId: getdata[i].PersonaId, LanguageId: getdata[i].LanguageId };
                }
                this.setState({ planguagelist });
            }
            );
        axios.get('ReactPerson/GetAllCountries')
            .then((response) => {

                var getdata = JSON.parse(response.data);
                var countrylist = new Array(getdata.length);
                for (let i = 0; i < getdata.length; i++) {
                    countrylist[i] = { Name: getdata[i].Name, Id: getdata[i].Id };
                }

                this.setState({ countrylist });
            }
            );
    }
    getLanguagesWithPerson(persons, languages, planguages) {
        var languagestring = 'Languages: | ';
        for (let i = 0; i < planguages.length; i++) {
            for (let j = 0; j < languages.length; j++) {
                if (planguages[i].PersonaId == persons.Id && languages[j].Id == planguages[i].LanguageId) {
                    languagestring += languages[j].Name + ' | ';
                }

            }
        }
        return languagestring;
    }
    getCityName(personcityid, cities, countries) {

        for (let i = 0, len = cities.length; i < len; i++) {
            for (let j = 0; j < countries.length; j++) {
                if (personcityid == cities[i].Id && countries[j].Id == cities[i].CountryId) {
                    return cities[i].Name + ',' + countries[j].Name;
                }
            }
        }

        return 'NOT FOUND';
    }
    showDetalis(persons, cities, countries, languages, planguages) {


        var details = persons.Id + ' Name: ' + persons.Name + ' City: ' + this.getCityName(persons.CityId, cities, countries) + ' Phone: ' + persons.PhoneNumber;
        var languagestring = this.getLanguagesWithPerson(persons, languages, planguages);

        this.setState({ details, languagestring });

    }
    render() {return(
    <div className="card border border-secondary shadow-0">
    <div className="card-header bg-secondary text-white"><b>Display</b> Libraries</div>
    <div className="card-body">
        <table className="table table-striped">
            <thead>
                <tr>
                    <th>Name</th>
                            <th>City</th>
                            <th>Country</th>
                    <th>Telephone</th>
                    <th></th>
                </tr>
                    </thead>
{this.state.namelist.map(item => {
            <tbody>
                
                        <tr >

                    <td>{item.Name}</td>
                        <td>Mariestad</td>
                        <td>Sweden</td>
                        <td>
                            
                                <button type="button" className="btn btn-info mr-2"> Details</button>
                                
                                
                            
                        </td>
                    </tr>
               
            </tbody>
})}
        </table>
    </div>
        </div>
        )}
}

function App() {
    return (
        <div>
            <Welcome name="Sara" />
            <Welcome name="Cahal" />
            <Welcome name="Edite" />
        </div>
    );
}


ReactDOM.render(
    <AddPerson />,
    document.getElementById('Test2')

);
ReactDOM.render(
    <DisplayPeople />,
    document.getElementById('Test3')

);
