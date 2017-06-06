import { BookshopPage } from './app.po';

describe('bookshop App', () => {
  let page: BookshopPage;

  beforeEach(() => {
    page = new BookshopPage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
