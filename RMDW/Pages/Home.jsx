import { useEffect, useState } from "react";
import Object from "../src/component/Object";
import Subject from "../src/component/Subject";

function Home () {
    const [object, setObject] = useState([]);
    const [subject, setSubject] = useState([]);

    useEffect(() => {
        fetch("/data/object.json")
        .then(res => res.json)
        .then(data => setObject(Data));

        fetch("/data/subject.json")
        .then(res => res.json)
        .then(data => setSubject(Data));
    }, []);

return (
    <main>
        <h3>Should We Learn Programming in FPT Aptech?</h3>
        <div className="object-list">
            {object.Data(item =>(
                <Object key={item.id} data={item}/>
            ))}
        </div>

        <h3>What Is The Course Program?</h3>
        <div className="subject-list">
            {subject.Data(item => (
                <Subject key={item.id} subject={item}/>
            ))}
        </div>
    </main>
);
}

export default Home;