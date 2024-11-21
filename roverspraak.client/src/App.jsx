import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [roverMessages, setRoverMessages] = useState();


    useEffect(() => {
        populateRoverData();
    }, []);

    const contents = roverMessages === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>Created</th>
                    <th>Alias</th>
                    <th>Message</th>
                </tr>
            </thead>
            <tbody>
                {roverMessages.map(roverMessage =>
                    <tr key={roverMessage.id}>
                        <td>{roverMessage.created}</td>
                        <td>{roverMessage.alias}</td>
                        <td>{roverMessage.roverText}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">Roverspraak</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
    
    async function populateRoverData() {
        const response = await fetch('roverspraak');
        if (response.ok) {
            const data = await response.json();
            setRoverMessages(data);
        }
    }
}

export default App;