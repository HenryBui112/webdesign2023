import SubjectCard from "./SubjectCard";

export default function SubjectSection({ subjects }) {
  return (
    <section className="section subjects" id="subjects">
      <div className="section-title">
        <h2>WHAT IS THE COURSE PROGRAM?</h2>
        <p>Explore the technologies included in the programming curriculum.</p>
      </div>
      
      <div className="subject-grid">
        {subjects.map((subject) => (
          <SubjectCard key={subject.id} subject={subject} />
        ))}
      </div>
    </section>
  )
}
