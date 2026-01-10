function Object () {
    return (
        <div className="object">
            <img src={data.image} alt={data.title}/>
            <h2>{data.title}</h2>
            <p>{data.description}</p>
        </div>
    );
}
export default Object;