
class ShowPeople extends React.Component {
    
    render() {
        return (
            <div className="pshow">SJ</div>
        )
    }
}
function CreatePeopl() {return <h4>HOVA</h4>}
class CreatePeople extends React.Component {
    render() {
        return (<div className="pcreate">createpeople</div>);
    }
}
class PersonDetails extends React.Component {
    render() {
        return (<div className="pdetails">details</div>);
    }
}
const baseURL = "ReactPerson/GetAllPeople";
class GetRequest extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
           persondetail: null,
            namelist: [],
            citylist: [],
            languagelist: [],
            planguagelist: [],
            countrylist:[]
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
                    citylist[i] = { Name: getdata[i].Name, Id: getdata[i].Id, CountryId: getdata[i].CountryId};
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
                if (planguages[i].PersonaId == persons.Id && languages[j].Id == planguages[i].LanguageId ) {
                    languagestring += languages[j].Name + ' | ';
                }
                
            }
        }
        return languagestring;
    }
    getCityName(personcityid, cities, countries) {

        for (let i = 0, len = cities.length; i < len; i++) {
            for (let j = 0; j<countries.length; j++) {
                if (personcityid == cities[i].Id && countries[j].Id==cities[i].CountryId ) {
                    return cities[i].Name + ','+countries[j].Name;
                }
            }
        }

        return 'NOT FOUND';
    }
    showDetalis(persons, cities, countries, languages, planguages) {
        
        
        var details = persons.Id + ' Name: ' + persons.Name + ' City: ' + this.getCityName(persons.CityId, cities,countries) + ' Phone: ' + persons.PhoneNumber;
        var languagestring = this.getLanguagesWithPerson(persons, languages, planguages);

        this.setState({ details,languagestring });
        
    }
    

    render() {
        
       
        return (
            <div className="card text-center m-3">
                <h5 className="card-header">Showing people</h5>
                <div className="card-body">
                    People:
                    <table border="1">
                        {this.state.namelist.map(item => {
                            return <tbody>
                                <tr>
                                    <td>{item.Name}</td>
                                    <td><button onClick={() => this.showDetalis(item, this.state.citylist, this.state.countrylist, this.state.languagelist,this.state.planguagelist)}>Details</button></td>
                                </tr></tbody>
                        })}
                    </table>
                    
                    <p>{this.state.details}</p>
                    <p>{this.state.languagestring}</p>
                    
                    
                </div>
            </div>
        );
    }
}
class PostRequest extends React.Component{
    state = { name: '' }
    handleChange = event => {
        this.setState({ name: event.target.value });
    }
    handleChange = event => {
        this.setState({ name: event.target.value });
    }
    handleSubmit = event => {
        event.preventDefault();
        
        const user = {
            name: this.state.name
        };

        axios.post(`ReactPerson/GetAllPersona_Languages`, { user })
            .then(res => {
                console.log(res);
                console.log(res.data);
            })
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <label>Enter your name:
                    <input type="text" name="name" onChange={this.handleChange}/>
                </label>
                <label>Enter your Tele:
                    <input type="text" />
                </label>
                <label>Enter your City:
                    <input type="text" />
                </label>
                <button type="submit">Add</button>
            </form>
        )
    }
}
ReactDOM.render(<GetRequest />, document.getElementById('pd'));
ReactDOM.render(<PostRequest />, document.getElementById('ps'));
ReactDOM.render(<CreatePeopl />, document.getElementById('pc'));
