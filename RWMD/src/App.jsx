import {useState} from 'react';
import objects from './data/objects.json';
import subjects from './data/subjects.json';
import Header from './components/Header';
import Hero from './components/Hero';
import ObjectSection from './components/ObjectSection';
import SubjectSection from './components/SubjectSection';
import Footer from './components/Footer';
import LoginModal from './components/LoginModal';

export default function App() {
  const [modal, setModal] = useState(null);

    return (
        <div className="app" id="top">
            <Header
                onSignIn={() => setModal('signin')}
                onSignUp={() => setModal('signup')}
            />

            <main>
                <Hero />
                <ObjectSection objects={objects} />
                <SubjectSection subjects={subjects} />
            </main>

            <Footer />

            {modal && (
                <LoginModal
                    type={modal}
                    onClose={() => setModal(null)}
                />
            )}
        </div>
    );
}