function Subject () {
    return (
        <div className="Subject">
            <img src={Subject.icon} alt={subject.name}/>
            <p>{subject.name}</p>
        </div>
    );
}
export default Subject;