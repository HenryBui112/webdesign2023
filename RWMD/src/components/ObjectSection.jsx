import ObjectCard from "./ObjectCard";

export default function ObjectSection({ objects }) {
  return (
    <section className="section" id="objects">
      <div className="section-title">
        <h2>SHOULD WHO LEARN PROGRAMMING IN FPT APTECH?</h2>
        <p>Choose the learning path that matches your current stage.</p>
      </div>
      
      <div className="object-grid">
        {objects.map((object) => (
          <ObjectCard key={object.id} object={object} />
        ))}
      </div>
    </section>
  )
}