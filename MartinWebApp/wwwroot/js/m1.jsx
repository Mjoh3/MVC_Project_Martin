
class GetRequest extends React.Component {
    constructor(props) {
        super(props);
        
        this.state = {
            name: '', tele: '', city: '-1', country: '-1', responsemessage: '',
            persondetail: null,
            namelist: [],
            citylist: [],
            languagelist: [],
            planguagelist: [],
            countrylist: [],
            personid:'',
            sorted: false

        };
        this.getFromDB();
        
    }
    
    componentDidMount() {
        
    }
    
    getFromDB() {
        // Simple GET request using axios
        axios.get('ReactPerson/GetAllPeople')
            .then((response) => {

                var persondata = JSON.parse(response.data);
                var plist = new Array(persondata.length);
                for (let i = 0; i < persondata.length; i++) {
                    plist[i] = { Name: persondata[i].Name, Id: persondata[i].Id, CityId: persondata[i].CityId, PhoneNumber: persondata[i].PhoneNumber };
                }
                this.setState({ namelist:plist });
            }
            );
        axios.get('ReactPerson/GetAllCities')
            .then((response) => {

                var getdata = JSON.parse(response.data);
                var citylist = new Array(getdata.length);
                for (let i = 0; i < getdata.length; i++) {
                    citylist[i] = { Name: getdata[i].Name, Id: getdata[i].Id, CountryId: getdata[i].CountryId };
                }
                
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

        this.setState({ details,languagestring,personid: persons.Id });
        
    }
    deleteperson(){
        if (this.anypersonwithid()==true) {
            $.post("/ReactPerson/DeletePersona", { id: this.state.personid });

            this.deletefromlistbyid();
            
            this.setState({ personid: '-1' });
            this.setState({
                details:'', languagestring:''
            });
            console.log(this.state.namelist);
        }
        else {
            this.setState({ responsemessage: 'could not delete' });
        }
    }
    sortperson() {
        var sortedlist = this.state.namelist.sort((a, b) => a.Name.localeCompare(b.Name));
        this.setState({namelist: sortedlist,sorted:true});
    }
    sortpersonbyid() {
        var sortedlist = this.state.namelist.sort((a, b) => a.Id>b.Id);
        this.setState({ namelist: sortedlist,sorted:false });
    }
    
    deletefromlistbyid() {
        
        var mylist = this.state.namelist;
        for (var i = 0; i < this.state.namelist.length; i++) {

            if (mylist[i].Id.toString() == this.state.personid) {

                mylist.splice(i, 1);
            }

        }
        this.setState({ namelist: mylist });
    }
    addpersontolist(p) {
        var mylist = this.state.namelist;
        mylist.push({ Name: p.name, Id: p.id, CityId: p.cityId, PhoneNumber: p.phoneNumber });
        
        this.setState({ namelist: mylist });
        if (this.state.sorted) {
            this.sortperson();
        }
    }
    anypersonwithid() {
        var mylist = this.state.namelist;
        for (var i = 0; i < this.state.namelist.length; i++) {

            if (mylist[i].Id.toString() == this.state.personid) {

                return true;
            }

        }
        return false;
    }
    updateName = event => {
        this.setState({ name: event.target.value });
    }
    updateTele = event => {
        this.setState({ tele: event.target.value });
    }
    updateCity = event => {
        this.setState({ city: event.target.value });
    }
    updateCountry = event => {
        this.setState({ country: event.target.value });
    }


    addPersonToDb = event => {
        event.preventDefault();

        var inputID = this.state.name;
        console.log(this.state.name);
        console.log(this.state.city);
        console.log(this.state.tele);
        if (this.state.name.length > 0 &&
            this.state.tele.length > 0 &&
            this.state.city != '-1' &&
            this.state.city != null &&
            this.state.tele != null &&
            this.state.name != null) {
            this.setState({ responsemessage: '' });
            $.post("/ReactPerson/AddPerson", { name: this.state.name, cities: this.state.city, phonenumber: this.state.tele }, function (data) {
                
                console.log(data);
                this.addpersontolist(data);
            }.bind(this)

            );
             

        }
        else {
            this.setState({ responsemessage: 'could not add' });
        }
    }
    
    render() {
        
        let iteritems = this.state.namelist.map(item => {
            
            return (

                <tr>
                    <td>{item.Name}</td>
                    <td><button onClick={() => this.showDetalis(item, this.state.citylist, this.state.countrylist, this.state.languagelist, this.state.planguagelist)}>Details</button></td>
                </tr>)
        });

        let countryoptions = this.state.countrylist.map(item => {
            return (<option value={item.Id.toString()}>{item.Name}</option>)
        });
        let cityoptions = this.state.citylist.map(item => {
            if (this.state.country == item.CountryId) {
                return (

                    <option value={item.Id.toString()}>{item.Name}</option>

                )
            }
        });

        return (
            <div>
            <div className="card text-center m-3">
                <h5 className="card-header">Showing people</h5>
                <div className="card-body">
                   
                    <table className="table table-striped"><tbody>
                        
                            {iteritems}
                           
                        </tbody></table>
                        {this.state.sorted ?
                            <button onClick={() => this.sortpersonbyid()}>unsort</button> :
                            <button onClick={() => this.sortperson()}>sort by name </button>
                        }
                        
                    
                    
                    
                </div>
            </div>
                <div className="card text-center m-3">
                    <h5 className="card-header">Details</h5>
                    <div className="card-body">
                    </div>
                    <p>{this.state.details}</p>
                    <p>{this.state.languagestring}</p>
                    {this.anypersonwithid() ? <button variant="primary" size="sm" onClick={() => this.deleteperson()}>DELETE PERSON</button> : <></>}
                </div>
                <div className="card text-center m-3">
                    <h5 className="card-header">Add a person</h5>
                    <div className="card-body">
                        <form onSubmit={this.addPersonToDb}>
                        <label>Enter Name:
                            <input type="text" name="name" onChange={this.updateName} />
                    
                        </label>
                        <label>Enter City:
                            <select name="countries" onChange={this.updateCountry}>
                                <option value="-1">pick a country</option>
                                {countryoptions}

                            </select>
                            <select name="cities" onChange={this.updateCity}>
                                <option value="-1">pick a city</option>
                                {cityoptions}
                        
                                </select>
                        </label>
                        <label>Enter Telephone number:
                            <input type="text" name="tele" onChange={this.updateTele}/>
                        </label>
                        <button type="submit">Add</button>
                        <p>{this.state.responsemessage}</p>
                        </form>
                        </div></div>
                </div>
        );
    }
}



ReactDOM.render(<GetRequest />, document.getElementById('pd'));


