export default function ObjectCard({ object }) {
    return (
        <article className="object-card">
            <img src={object.image} alt={object.title} />
            <div className="object-body">
                <h3>{object.title}</h3>
                <p>{object.description}</p>
                <button className="read-more">LEARN MORE →</button> 
              </div>
        </article>
    )
}